<!--Peter Hamilton 21/2/24-->
<!-- Navbar.svelte -->
<script>
    import logo from '$lib/assets/logo.svg';
    import '@fontsource-variable/source-code-pro';
    import '@fontsource/gugi';
    
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
      font-family: 'Gugi', system-ui;        
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
  
    @media (max-width: 768px) {
      .navbar {
        flex-direction: column;
        text-align: center;
      }
  
      .navbar-links {
        margin-top: 10px;
        justify-content: center; 
      }
    }
  </style>
  
  <div class="navbar">
    <div class="navbar-brand">
      <a href="/"><div class="logo-container">
        <span class="logo-text">Pa1yN-Dev</span>
      </div></a>
    </div>
    <div class="navbar-links">
    </div>
  </div>
  