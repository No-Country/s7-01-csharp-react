import React from "react";
import { Navigate } from "react-router-dom";

export function PublicRoutes({ isLogged, children }) {
<<<<<<< HEAD
  return isLogged ? <Navigate to="/app/home" /> : children;
=======
  return isLogged ? <Navigate to="/" /> : children;
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
}
