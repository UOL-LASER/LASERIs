<!--Peter Hamilton 21/2/24--> 
<!--Index.svelte-->
<script>
    import logo from '$lib/assets/logo-2.png';

    import '@fontsource-variable/exo-2';
    import '@fontsource-variable/orbitron';
</script>

<style>
    .body {
        background-color: white;
        margin: 0;
        padding: 0;
        min-height: 100vh;
        background-image: url('/src/lib/assets/background-2.jpg');
        background-size: cover;
        background-repeat: no-repeat;
        background-position: 50% 35%;
    }
    
    .wip {
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        padding: 100px 0px;
    }

    .wip h1 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 3vh;
        text-align: center;
        text-decoration: underline;
        margin: 10px auto;
        color: white;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 
    }

    .wip p {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 2.5vh;
        text-align: center;
        margin: 10px auto;
        color: white;
        font-style: italic;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 
    }

    .wip img {
        margin-bottom: 20px;
        margin: 10px auto;
        width: 50vh; 
        height: auto;
    }

    @media (max-width: 768px) {
        .wip img {
        margin-bottom: 20px;
        margin: 10px auto;
        width: 40vh; 
        height: auto;
    }
    }  

</style>

<div class="body">
    <div class="wip">
        <img src="{logo}" alt="LASER Logo">
        <h1>Work in progress:</h1>
    </div>
</div>


