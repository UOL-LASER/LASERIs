<!--Peter Hamilton 21/2/24-->
<script>
    import '@fontsource-variable/source-code-pro';
    import '@fontsource/gugi';

    import email from '$lib/assets/icons/email.svg';
    import linkedin from '$lib/assets/icons/linkedin.svg';

    const currentYear = new Date().getFullYear();
</script>

<style>
    .footer {
        background: #111111;
        color: white;
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        position: relative;
        padding: 1vh; 
        margin: 0; 
        max-width: 100%;
        border-top: 1px solid rgb(255, 255, 255);
        height: auto;
        z-index: 999;
    }

    .footer p {
        margin: 0;
        font-family: 'Gugi', system-ui;        
        padding: 1vh;
        font-size: 18px;
    }

    .footer-icons {
        display: flex;
        justify-content: space-evenly; 
        align-items: center;
        width: 50%; 
        padding: 2vh;
    }

    .footer-icons a {
        flex-grow: 1; 
        display: flex;
        justify-content: center;
        align-items: center;
        position: relative; 
        text-decoration: none;
        
    }

    .footer-icons img {
        width: 100%; 
        max-width: 4vh; 
        height: auto;
        margin: 0 2vw;
        filter: invert(1);
        transition: filter 0.3s ease
    }

    .footer-icons img:hover {
        filter:invert(0);
    }

    .footer-icons a:not(:last-child)::after {
        content: "";
        border-right: 1px solid white;
        height: 80%;
        position: absolute;
        right: 0; 
        top: 10%; 
    }

    @media (max-width: 768px) {
      .footer-icons {
        display: flex;
        justify-content: space-evenly; 
        align-items: center;
        width: 100%; 
        padding: 2vh;
    }    
    }
</style>

<div class="footer">
    <div class="footer-icons">
        <a href="https://www.linkedin.com/in/phamilton360"><img src={linkedin} alt="LinkedIn"></a>
        <a href="mailto:laser@liverpool.ac.uk"><img src={email} alt="Email"></a>
    </div>

    <p>&copy; Peter Hamilton {currentYear}</p>
</div>

