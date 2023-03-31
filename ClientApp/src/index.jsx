import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';

import { BrowserRouter } from 'react-router-dom';
import * as serviceWorkerRegistration from './serviceWorkerRegistration';
import reportWebVitals from './reportWebVitals';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');

const root = ReactDOM.createRoot(document.getElementById('root'));

//root.render(
//  <React.StrictMode>
//    <App />
//  </React.StrictMode>
//);

root.render(
    <BrowserRouter basename={baseUrl}>
        <App />
    </BrowserRouter>);


serviceWorkerRegistration.unregister();
reportWebVitals();