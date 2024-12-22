<!--Peter Hamilton 06/3/24--> 
<script>
    import '@fontsource-variable/exo-2';
    import '@fontsource-variable/orbitron';
</script>
<style>
.nav-link {
  background-color: #111111;
  color: white;
  border: none;
  text-decoration: none;
  padding: 0;
  font-size: 18px; 
  transition: color 0.3s ease;
  font-family: 'Orbitron Variable', sans-serif;
}

.nav-link:hover {
      color: #58a6ff; 
    }

.dropdown {
  position: relative;
  display: inline-block;
}

.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f1f1f1;
  border-radius: 5px;
  margin: 0;
  width: 160px; 
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
  left: 50%; 
  transform: translateX(-49.5%); 
  opacity: 0.5; 
  transition: opacity 0.3s ease-in-out;;
}

.dropdown-content a {
  color: black;
  border-radius: 5px;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
  font-family: 'Exo 2 Variable';
  text-align: center;
}

.dropdown-content:hover {display: block; opacity: 1;}
.dropdown-content a:hover {background-color: #f1f1f1;}
.dropdown:hover .dropdown-content {display: block;}
.dropdown:hover .nav-link {background-color: #111111;}
</style>
<div class="dropdown">
    <button class="nav-link">Resources</button>
    <div class="dropdown-content">
      <a href="/resources/hear">HEAR Accreditation</a>
      <a href="/resources/newsletter">Newsletter</a>
      <a href="/resources/tos">LASER TOS and SOP</a>
    </div>
  </div>