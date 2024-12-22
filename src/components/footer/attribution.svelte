<script>
  import { createEventDispatcher } from 'svelte';

  export let show = false;
  const dispatch = createEventDispatcher();

  function close() {
    show = false;
    dispatch('close');
  }
</script>

<style>
  .popup {
      position: fixed;
      top: 50%;
      left: 50%;
      transform: translate(-50%, -50%);
      background: white;
      padding: 1rem;
      box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
      z-index: 1000;
      border-radius: 10px;
      display: flex;
      flex-direction: column;
      justify-content: space-between;
  }

  .overlay {
      position: fixed;
      top: 0;
      left: 0;
      right: 0;
      bottom: 0;
      background: rgba(0, 0, 0, 0.5);
      backdrop-filter: blur(8px);
      z-index: 999;
  }

  .hidden {
      display: none;
  }

  .button {
      padding: 10px 20px;
      font-size: 2vh;
      font-family: 'Exo 2 Variable';
      margin: 0 10px;
      background-color: #111111;        
      color: #ffffff;
      border: none;
      border-radius: 5px;
      transition: all 0.3s ease;
      cursor: pointer;  
  }

  .button:hover {
      filter: invert(1);
      transform: scale(1.05);
  }

  .content-row {
      padding: 10px;
      background-color: #ffffff;
      color: #000000;
      border-top: 1px solid rgb(255, 255, 255);
      margin: 10px auto;
  }

  .container {
      background-color: #f1f1f1;
      border-radius: 10px;
      padding: 10px;
      margin: 0px auto;
  }

  .container a {
    display: flex;
    margin: 10px auto;
    justify-content: center;
    align-items: center;
    padding: 20px;
    font-size: 2vh;
    text-align: center;
    text-decoration: none;
    transition: color 0.3s ease;
    font-family: 'Orbitron Variable', sans-serif;
    color: #000000;
  }

  .container a:hover {
        color: #58a6ff;
    }

  .content-row h1 {
      font-family: 'Orbitron Variable', sans-serif;
      font-size: 3vh;
      color: #000000;
      text-align: center;
      margin: 10px auto;
  }

  .content-row p {
      font-family: 'Exo 2 Variable';
      font-size: 2vh;
      text-align: center;
      color: #000000;
      line-height: 1.6;
      padding: 20px;
      margin: 10px auto;
  }

  .separator {
      content: "";
      display: block;
      height: 2px;
      background-color: black;
      border-radius: 1px; 
      width: 80%; 
      margin: 10px auto;
  }

  .button-container {
      display: flex;
      justify-content: center;
  }

</style>

<div class:overlay={show} class:hidden={!show}></div>
<div class="popup" class:hidden={!show}>
  <div class="content-row">
      <div class="container">
          <h1>Attribution:</h1>
          <p>The LASER Website is developed and maintained by:</p>
          <div class="separator"></div>
          <a href="https://www.linkedin.com/in/phamilton360/">Kitt Hamilton</a>
      </div>
  </div>
  <div class="button-container">
      <button class="button" on:click={close}>Close</button>
  </div>
</div>
