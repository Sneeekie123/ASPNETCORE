const btn = document.querySelector('#mobile-menu-btn');

btn.addEventListener('click', () => {
    const menu = document.querySelector('#mobile-menu')
    menu.ariaExpanded = !JSON.parse(menu.ariaExpanded)
});