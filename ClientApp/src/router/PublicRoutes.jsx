import React from "react";
import { Navigate } from "react-router-dom";

export function PublicRoutes({ isLogged, children }) {
  return isLogged ? <Navigate to="/app/home" /> : children;
}
