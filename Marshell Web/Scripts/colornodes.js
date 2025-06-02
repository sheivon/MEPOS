(() => {
    'use strict'

    const getStoredTheme = () => localStorage.getItem('theme')
    const setStoredTheme = theme => localStorage.setItem('theme', theme)

    const getPreferredTheme = () => {
        const storedTheme = getStoredTheme()
        if (storedTheme) {
            return storedTheme
        }

        return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
    }

    const setTheme = theme => {
        if (theme === 'auto') {
            document.documentElement.setAttribute('data-bs-theme', (window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'))
        } else {
            document.documentElement.setAttribute('data-bs-theme', theme)
        }
    }

    setTheme(getPreferredTheme())

    const showActiveTheme = (theme, focus = false) => {
        const themeSwitcher = document.querySelector('#bd-theme')

        // Check if the themeSwitcher exists before proceeding
        if (!themeSwitcher) {
            console.error('Theme switcher button (#bd-theme) not found!');
            return;
        }

        const themeSwitcherText = document.querySelector('#bd-theme-text')
        const activeThemeIcon = document.querySelector('.theme-icon-active i')  // Targeting the <i> tag now

        if (!activeThemeIcon) {
            console.error('Active theme icon (.theme-icon-active) not found!');
            return;
        }

        const btnToActive = document.querySelector(`[data-bs-theme-value="${theme}"]`)

        if (!btnToActive) {
            console.error(`Theme button for ${theme} not found!`);
            return;
        }

        let activeIconClass;
        if (theme === 'light') {
            activeIconClass = 'fas fa-sun'; // Font Awesome light theme icon
        } else if (theme === 'dark') {
            activeIconClass = 'fas fa-moon'; // Font Awesome dark theme icon
        } else if (theme === 'auto') {
            activeIconClass = 'fas fa-adjust'; // Font Awesome auto theme icon
        }

        // Removing and adding classes for active theme button
        document.querySelectorAll('[data-bs-theme-value]').forEach(element => {
            element.classList.remove('active')
            element.setAttribute('aria-pressed', 'false')
        })

        btnToActive.classList.add('active')
        btnToActive.setAttribute('aria-pressed', 'true')

        // Update the icon class
        activeThemeIcon.setAttribute('class', activeIconClass)

        const themeSwitcherLabel = `${themeSwitcherText.textContent} (${btnToActive.dataset.bsThemeValue})`
        themeSwitcher.setAttribute('aria-label', themeSwitcherLabel)

        if (focus) {
            themeSwitcher.focus()
        }
    }

    window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', () => {
        const storedTheme = getStoredTheme()
        if (storedTheme !== 'light' && storedTheme !== 'dark') {
            setTheme(getPreferredTheme())
        }
    })

    window.addEventListener('DOMContentLoaded', () => {
        showActiveTheme(getPreferredTheme())

        document.querySelectorAll('[data-bs-theme-value]')
            .forEach(toggle => {
                toggle.addEventListener('click', () => {
                    const theme = toggle.getAttribute('data-bs-theme-value')
                    setStoredTheme(theme)
                    setTheme(theme)
                    showActiveTheme(theme, true)
                })
            })
    })
})()
