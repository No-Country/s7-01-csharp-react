import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';
<<<<<<< HEAD
import mkcert from 'vite-plugin-mkcert'

// https://vitejs.dev/config/
export default defineConfig({
    server: {
        proxy: {
            "/weatherforecast*": {
                target: "https://localhost:7280",
                changeOrigin: true,
                secure: false,
            },
            "/swagger": {
                target: "https://localhost:7280",
                changeOrigin: true,
                secure: false,
            },
             "/api": {
                target: "https://localhost:7280",
                changeOrigin: true,
                secure: false,
            }

        },
    },
    plugins: [react(), mkcert()],
=======

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react()],
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
});
