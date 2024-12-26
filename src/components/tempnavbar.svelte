<!--Peter Hamilton 28/2/24-->
<!-- Navbar.svelte -->
<script>
    import logo from '$lib/assets/logo-2.png';
    import '@fontsource-variable/exo-2';
    import '@fontsource-variable/orbitron';
  </script>
  
  <style>
    /* Add your CSS styles here */
    .navbar {
      background: #111111; 
      display: flex;
      align-items: center;
      position: fixed;
      justify-content: center;
      top: 0;
      width: 100%;
      z-index: 1000;
      padding: 1vh; 
      margin: 0; 
      border-bottom: 1px solid rgb(255, 255, 255);
    }
  
    .logo-container {
      display: flex;
      align-items: center;
      
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
      <div class="logo-container">
        <img src={logo} alt="LASER Logo">
        <span class="logo-text">LASER</span>
      </div>
    </div>
  </div>
  