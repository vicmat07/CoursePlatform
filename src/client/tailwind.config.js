/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,ts}"],
  theme: {
    extend: {
      fontFamily: {
        sans: ['Inter', 'system-ui', 'sans-serif'], // fonte global
        heading: ['Poppins', 'sans-serif'],        // fonte para headers
      },
      colors: {
        brand: {
          DEFAULT: '#1e40af',
          light: '#3b82f6',
          dark: '#1e3a8a'
        }
      }
    },
  },
  plugins: [],
}

