<!--Peter Hamilton 21/2/24-->
<!-- Navbar.svelte -->
<script>
    import logo from '$lib/assets/logo-2.png';
    import '@fontsource-variable/exo-2';
    import '@fontsource-variable/orbitron';

    import Dropdown from './resources/dropdown.svelte';
    
  </script>
  
  <style>
    .navbar {
      background: #111111; 
      display: flex;
      align-items: center;
      position: fixed;
      top: 0;
      width: 100%;
      z-index: 999;
      padding: 1vh; 
      margin: 0; 
      border-bottom: 1px solid rgb(255, 255, 255);
    }

    .navbar-brand a {
      text-decoration: none;
    }

    .navbar-brand {
      transition: all 0.3s ease;
    }
    .navbar-brand:hover {
      transform: scale(1.05)
    }
  
    .logo-container {
      display: flex;
      align-items: center;
      margin-left: 2vw;
    }
  
    .logo-container img {
      width: 6vh; 
      height: auto;
    }
  
    .logo-text {
      font-family: 'Orbitron Variable', sans-serif;
      font-size: 4vh;
      color: white;
      margin-left: 5px; 
    }
  
    .navbar-links {
      flex: 1; 
      display: flex;
      justify-content: right;
      margin-right: 2vw;
    }
  
    .navbar-links ul {
      display: flex;
      list-style: none;
      margin: 0 2vw;
      padding: 0;
    }
  
    .navbar-links li:not(:last-child)::after {
      content: "";
      border-right: 1px solid white;
      height: 100%; 
      margin-left: 2vw;
      margin-right: 2vw;
      color: white;
    }
  
    .navbar-links a {
      color: white;
      text-decoration: none;
      font-size: 18px; 
      transition: color 0.3s ease;
      font-family: 'Orbitron Variable', sans-serif;
    }
  
    .navbar-links a:hover {
      color: #58a6ff; 
    }
  
    @media (max-width: 768px) {
      .navbar {
        flex-direction: column;
        text-align: center;
      }
  
      .navbar-links {
        margin-top: 10px;
        justify-content: center; 
      }
  
      .navbar-links li {
        margin: 10px 0; 
      }
  
      .navbar-links li:not(:last-child)::after {
        content: "";
        border-right: 1px solid white;
        height: 100%; 
        margin-left: 4vw;
        margin-right: 4vw;
        color: white;
      }
    }
  </style>
  
  <div class="navbar">
    <div class="navbar-brand">
      <a href="/"><div class="logo-container">
        <img src={logo} alt="LASER Logo">
        <span class="logo-text">LASERIS</span>
      </div></a>
    </div>
    <div class="navbar-links">
      <ul>
        <li>
          <a class="nav-link" href="/projects" rel="prefetch">Sign-in</a>
        </li>
        <li>
          <a class="nav-link" href="/about" rel="prefetch">Sign-out</a>
        </li>
      </ul>
    </div>
  </div>
  