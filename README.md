# Blog Angular
<h2> run app </h2>
npm install <br />
ng serve

<h2> Install bootstrap 4 </h2>
<pre >
npm install jquery --save 
npm install popper.js --save
npm install bootstrap@4 jquery --save

register css and js in angular.json 

"styles": [
    "src/styles.css",
    "node_modules/bootstrap/dist/css/bootstrap.min.css"
],
"scripts": [
    "node_modules/jquery/dist/jquery.slim.min.js",
    "node_modules/popper.js/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js"
]
</pre>

<h2> Requeriments </h2>

<ul>
  <li>Home</li>
  <li>Articles</li>
  <li>Categories</li>
  <li>Profile</li>
  <li>Users</li>
</ul>

<h2> Server </h2>
localhost:port/api/values/:id
