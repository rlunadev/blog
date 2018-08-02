using System;
using System.Collections.Generic;
using blog.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace blog.Data
{
  public sealed class Repository
  {
    ISessionFactory _sessionFactory;
    ISession _session;

    private static readonly Repository _instance = new Repository();

    private Repository()
    {
      InitializeSession();
    }

    public static Repository Instance
    {
      get
      {
        return _instance;
      }
    }

    void InitializeSession()
    {
      try
      {
        _sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012
            .ConnectionString("Server=IATEC-4X2KWF2\\MSSQLSERVER2; Database=blog; Integrated Security=SSPI;"))
            .Mappings(m => m
            .FluentMappings.AddFromAssemblyOf<Repository>())
            .BuildSessionFactory();
        _session = _sessionFactory.OpenSession();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public IList<Categoria> GetAllCategorias()
    {
      try
      {
        return _session.QueryOver<Categoria>().List();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public Categoria GetCategoria(Guid id)
    {
      try
      {
        return _session.Get<Categoria>(id);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public Categoria AddCategoria(Categoria categoria)
    {
      Categoria entity = null;
      using (var transaction = _session.BeginTransaction())
      {
        try
        {
          categoria.Id = Guid.NewGuid();
          categoria.Fecha = DateTime.Now;
          entity = _session.Save(categoria) as Categoria;
          transaction.Commit();
        }
        catch (StaleObjectStateException ex)
        {
          try
          {
            entity = _session.Merge(categoria);
            transaction.Commit();
          }
          catch
          {
            transaction.Rollback();
            throw;
          }
        }
        return entity;
      }
    }

    public void UpdateCategoria(Categoria categoria)
    {
      using (var transaction = _session.BeginTransaction())
      {
        try
        {
          _session.Update(categoria);
          transaction.Commit();
        }
        catch (StaleObjectStateException ex)
        {
          try
          {
            _session.Merge(categoria);
            transaction.Commit();
          }
          catch
          {
            transaction.Rollback();
            throw;
          }
        }

      }
    }

    public void DeleteCategoria(Guid id)
    {
      using (var transaction = _session.BeginTransaction())
      {
        var categoria = _session.Get<Categoria>(id);
        if (categoria != null)
        {
          try
          {
            _session.Delete(categoria);
            transaction.Commit();
          }
          catch (StaleObjectStateException ex)
          {
            try
            {
              _session.Merge(categoria);
              transaction.Commit();
            }
            catch
            {
              transaction.Rollback();
              throw;
            }
          }
        }
      }
    }
  }
}
