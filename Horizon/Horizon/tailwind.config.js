/** @type {import('tailwindcss').Config} */
module.exports = {
    important: true,
    content: [
        './Components/**/*.{cs,razor}',
        '../**/*.{cs,razor}',
    ],
    theme: {
        extend: {},
    },
    plugins: [],
}

