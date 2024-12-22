<!--Kitt Hamilton 22/12/24--> 
<!--Index.svelte-->
<script>
    import '@fontsource-variable/exo-2';
    import '@fontsource-variable/orbitron';


</script>

<style>
    .body {
        background-color: white;
        margin: 0;
        padding: 0;
        min-height: 100vh;
    }

    .gallery-container {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
      gap: 20px;
      padding: 20px;
      margin: 20px auto;
      background-color: #ffffff;
    }

    .gallery-item {
      position: relative;
      overflow: hidden;
      background-color: #f1f1f1;
      border-radius: 10px;
      box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
      transition: transform 0.3s ease, filter 0.3s ease;
      cursor: pointer;
    }

    .gallery-item:hover {
      transform: scale(1.05);
      filter: invert(1);
    }

    .gallery-item img {
      width: 100%;
      height: auto;
      display: block;
      object-fit: cover;
      border-radius: 10px;
    }
    
    .header {
        background-image: url('/src/lib/assets/background-2.jpg');
        background-size: cover;
        background-repeat: no-repeat;
        background-position: 50% 35%;
        text-align: center;
        padding: 40px;
        color: white;
        height: 475px;
    }

    .header h1 {
        font-family: 'Orbitron Variable', sans-serif;
        padding: 20px;
        font-size: 3rem;
        margin: 10px 0;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 

    }

    .header h2 {
        font-family: 'Exo 2 Variable';
        padding: 20px;
        font-size: 1.5rem;
        margin: 10px 0;
        text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5); 
    }

    .buttons {
        display: flex;
        justify-content: center;
        padding: 20px;
        margin: 20px auto;
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
        padding: 20px;
        background-color: #ffffff;
        color: #000000;
        border-top: 1px solid rgb(255, 255, 255);
        margin: 10px auto;
    }

    .container {
        background-color: #f1f1f1;
        border-radius: 10px;
        padding: 20px;
        margin: 10px auto;
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
        margin: 20px auto;
    }

    .item-rowcontainer {
        display: flex;
        justify-content: center;
        width: 40%;
        margin: 10px auto;
        
    }

    .item-container {
        flex: 0 0 60%; 
        text-align: center;
        background-color: #f1f1f1;
        border-radius: 10px;
        padding: 20px;
        margin: 10px auto;
        transition: all 0.3s ease;
        cursor: pointer;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);

    }

    .item-container:hover {
        transform: scale(1.05);
        filter: invert(1);
    }
  
    .item-container img {
        width: 18vh;
        height: auto;
    }

    .item-container p {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 2vh;
        text-align: center;
        color: #000000;
        line-height: 1.6;
        padding: 20px;
        font-weight: bold;
        margin: 10px auto;
    }

    .vseparator::after {
        content: "";
        height: 100%; 
        margin-left: 2vw;
        margin-right: 2vw;
        color: white;
    }

    .gallery-container {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
      gap: 20px;
      padding: 20px;
      margin: 20px auto;
      background-color: #f1f1f1;
      border-radius: 10px;

    }


    @media (max-width: 768px) {
        .header {
        height: 620px;
    }

    .header h1 {
        padding: 10px;
        margin: 15px auto;
        font-size: 3rem;
    }

    .header h2 {
        padding: 10px;
        margin: 5px auto;
        font-size: 1.5rem;
    }

    .buttons {
        padding: 10px;
        margin: 5px auto;
    }

    .button {
        padding: 10px 20px;
        font-size: 2vh;
        font-family: 'Exo 2 Variable';
        margin: 0 auto;
    }

    .item-rowcontainer {
        overflow-x: auto;
        width: auto;
        display: inline;
        padding: 20px;
    }

    .item-container {
        flex: 0 0 auto; 
        min-width: 30%; 
    }

    .gallery-container {
      gap: 10px;
    }
}
</style>

<div class="body">
<div class="header">
    <h1>Liverpool Association For Space Engineering And Research</h1>
    <h2>A University of Liverpool student-run engineering society based in the Electrical and Electronics Engineering department.</h2>
    <div class="buttons">
        <button class="button"on:click={scrollToGetInvolved}>Get involved</button>
    </div>
</div>
<div class="content-row" id="projects-header">
    <div class="gallery-container">
            <Galleryitem url={week11}/>
            <div class="gallery-item">
                <a href="https://payments.liv.ac.uk/product-catalogue/uol-merchandise/school-of-electrical-engineering-electronics-computer-science/laser-hoodie">
                    <img src="{merch}"/>
                </a>
            </div>
    </div>
</div>
<div class="content-row">
    <div class="container">
        <h1>FAQ:</h1>
        <p>Some common questions commonly asked about LASER from prospective members.</p>
        <div class="separator"></div>
        <Faq question={"How can I start a project?"} answer={"To start a project just come along and bring it up in a meeting."}/>
        <Faq question={"Does it cost anything?"} answer={"No, participation in LASER does not cost anything apart from your time."}/>
        <Faq question={"How do I join?"} answer={"As we're not affiliated with the Guild, we have no sign up requirements. Simply just show up to our meetings as listed below."}/>
        <Faq question={"What sort of things do you do?"} answer={"Within LASER we mainly work to develop skills outside of the typically taught curriculum through projects, in addition we offer a range of FYP for third year EEE students."}/>
        <Faq question={"I lack technical skills/knowledge, can I still take part?"} answer={"We encourage anyone regardless of course and background with an interest to join, as our projects often cover a wide range of fields."}/>
        
        
    </div>
</div>
<div class="content-row" id="getinvolved-header">
    <h1>How to get involved:</h1>
    <p>If you are a student or a company and you want to get involved with LASER, we host events and weekly meetings throughout the year.</p>
    <div class="separator"></div>
    <Getinvolved/>
</div>
</div>

