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
  
    .content-row h1 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 3vh;
        color: #000000;
        text-align: center;
        margin: 10px auto;
    }
    .content-row h2 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 2vh;
        color: #000000;
        text-align: center;
        margin: 10px auto;
    }
    .content-row h3 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 2vh;
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

    .button-container {
        display: flex;
        justify-content: center;
    }

    .scroll-box {
        max-height: 60vh; 
        overflow-y: auto; 
        padding: 10px;
        background-color: #ffffff;
        border-radius: 10px;
    }

    .scroll-box h1 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 4vh;
        color: #000000;
        text-align: center;
        margin: 10px auto;
    }

    .scroll-box h2 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 3vh;
        color: #000000;
        text-align: center;
        margin: 10px auto;
    }

    .scroll-box h3 {
        font-family: 'Orbitron Variable', sans-serif;
        font-size: 2vh;
        color: #000000;
        text-align: center;
        margin: 10px auto;
    }

    .scroll-box ul {
        list-style: decimal;
    }

    .scroll-box ul li {
    font-family: 'Exo 2 Variable';
    font-size: 2vh;
    text-align: center;
    color: #000000;
    line-height: 1.6;
    padding: 20px;
    margin: 10px auto;
    }

    .scroll-box p {
        font-family: 'Exo 2 Variable';
        font-size: 2vh;
        text-align: center;
        color: #000000;
        line-height: 1.6;
        padding: 20px;
        margin: 10px auto;
    }


  
  </style>
  
  <div class:overlay={show} class:hidden={!show}></div>
  <div class="popup" class:hidden={!show}>
    <div class="content-row">
        <div class="container">
            <div class="scroll-box">
              <h1>Terms of Service</h1>
              <p>Last updated: December 2024</p>
              <p>
                  These Terms of Service (ToS) outline the rules, responsibilities, and processes for all members and committee members of LASER within the University of Liverpool. By participating in the society, You agree to these Terms.
              </p>
          
              <h2>General Conduct</h2>
              <ul>
                  <li><strong>Respect and Inclusion:</strong> All individuals must treat others with respect, regardless of background, opinion, or role within the society. Discrimination, harassment, or bullying of any kind is strictly prohibited.</li>
                  <li><strong>Professionalism:</strong> Members and committee members must act professionally, particularly when discussing sensitive matters like finances or personal disputes.</li>
                  <li><strong>Conflict Resolution:</strong> Disagreements must be handled respectfully and in line with society processes.</li>
              </ul>
          
              <h2>Financial Conduct</h2>
              <ul>
                  <li><strong>Transparency:</strong> All financial transactions must be documented clearly and openly, including deposits, event funds, and reimbursements.</li>
                  <li><strong>Equality in Financial Access:</strong> Members may not personally benefit from society funds without approval from the Chief Financial Officer(s).</li>
                  <li><strong>Documentation:</strong> Receipts or proof of transactions must be maintained on LASER SharePoint.</li>
                  <li><strong>Confidentiality:</strong> Personal financial details must be handled securely and only by authorized individuals.</li>
              </ul>
          
              <h2>Responsibilities of Members</h2>
              <ul>
                  <li><strong>Participation:</strong> Members are encouraged to actively participate in society events.</li>
                  <li><strong>Reporting Issues:</strong> Members must promptly report concerns like misconduct or financial irregularities.</li>
                  <li><strong>Policy Adherence:</strong> Members must follow society policies, including reporting and disciplinary procedures.</li>
              </ul>
          
              <h2>Responsibilities of Committee Members</h2>
              <ul>
                  <li><strong>Leadership:</strong> Committee members must act as role models and uphold the society’s values.</li>
                  <li><strong>Decision-Making:</strong> Decisions must prioritize the society's best interest, free from personal bias.</li>
                  <li><strong>Accountability:</strong> Committee members are accountable for their decisions and actions.</li>
              </ul>
          
              <h2>Disciplinary Actions</h2>
              <p>Failure to adhere to these ToS may result in disciplinary actions, including:</p>
              <ul>
                  <li><strong>Formal Warnings:</strong> Up to three warnings for rule violations.</li>
                  <li><strong>Suspension or Expulsion:</strong> For serious or repeated violations.</li>
                  <li><strong>Escalation:</strong> Serious incidents may be escalated to the University of Liverpool.</li>
              </ul>
          
              <h2>Financial Dispute Resolution</h2>
              <p>To resolve financial disputes:</p>
              <ul>
                  <li>Members must submit concerns in writing to the Society President.</li>
                  <li>The President and Chief Financial Officer(s) will review and respond.</li>
                  <li>Unresolved issues may escalate to a formal committee meeting.</li>
              </ul>
          
              <h2>Reporting Violations</h2>
              <ul>
                  <li>Reports must include evidence where possible (e.g., screenshots, witness statements).</li>
                  <li>Anonymous reports will be accepted, but anonymity may limit investigation scope.</li>
                  <li>All reports are handled confidentially with outcomes communicated promptly.</li>
              </ul>
          
              <h2>Academic Integrity and Original Work</h2>
              <ul>
                  <li><strong>Original Contributions:</strong> All work submitted for LASER projects must be original.</li>
                  <li><strong>Plagiarism:</strong> Plagiarism is strictly prohibited and may result in disciplinary action.</li>
              </ul>
          
              <h2>Amendments to the Terms of Service</h2>
              <p>These Terms may be updated periodically. Members will be notified of changes promptly.</p>
          
              <h2>Contact Us</h2>
              <p>If you have any questions regarding these Terms, please contact:</p>
              <p><strong>Email:</strong> laser@liverpool.ac.uk</p>
            </div>
        </div>
    </div>
    <div class="button-container">
        <button class="button" on:click={close}>Close</button>
    </div>
  </div>
  