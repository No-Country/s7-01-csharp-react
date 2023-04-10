import React from "react";
import { Routes, Route } from "react-router-dom";

// components
import Home from "../pages/Home";
import { Clinic } from "../pages/Clinic";
import PetInfo from "../pages/PetInfo/PetInfo";
import { AddPet } from "../pages/AddPet";

export function AppRouter() {
  return (
    <>
      <Routes>
        <Route path="/home" element={<Home />} />
        <Route path="/clinic" element={<Clinic />} />
        <Route path="/petinfo" element={<PetInfo />} />
        <Route path="/add-mascot" element={<AddPet />} />
      </Routes>
    </>
  );
}
