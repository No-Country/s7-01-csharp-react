import React from "react";
import { Routes, Route } from "react-router-dom";

// components
import Home from "../pages/Home";

export function AppRouter() {
  return (
    <>
      <Routes>
        <Route path="/home" element={<Home />} />
      </Routes>
    </>
  );
}
