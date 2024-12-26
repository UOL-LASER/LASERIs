<!-- Layout.svelte -->
<script lang="ts">
    import {fade} from 'svelte/transition'
    import {quintIn, quintOut} from 'svelte/easing'
    export let data

    import { onMount } from 'svelte';
	import Navbar from '../components/navbar.svelte';
	import Footer from '../components/footer.svelte';


    function setViewportMetaTag() {
        const meta = document.createElement('meta');
        meta.name = 'viewport';
        meta.content = 'width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no';
        document.head.appendChild(meta);
    }

    onMount(setViewportMetaTag);
</script>

<style>
    .body {
        background-image: url('$lib/assets/backgnd.png');
        background-size: cover;
        background-position: center; 

        margin: 0; 
        padding: 0;
        overflow-x: hidden;
    }
    .page {
        display: flex;
        flex-direction: column;
        min-height: auto;
        position: relative;
        max-width: 100%;
        margin: 0; 
        padding: 0; 
        padding: 6vh 0px 0px 0px;
    }
    main {
        flex: 1;
    }

    @media (max-width: 768px) {
        .page {
        padding: 70px 0px 0px 0px;
    }
    }
</style>

{#key data.url}
<div class="body" in:fade={{delay: 300, duration: 600, easing: quintIn}} out:fade={{delay: 150, duration: 300, easing: quintOut}}>
    <Navbar />
    <div class="page">
        <main>
            <article class="content-body"> 
                <slot/>
            </article>
        </main>
    </div>
    <Footer />
</div>
{/key}
