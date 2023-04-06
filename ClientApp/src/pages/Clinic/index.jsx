import { CoverClinic } from "../../components/CoverClinic";
import { DataClinic } from "../../components/DataClinic";
import { ContactClinic } from "../../components/ContactClinic";
import { InfoClinic } from "../../components/InfoClinic";
import { ServiceClinic } from "../../components/ServiceClinic";
import Navbar from "../../components/Layouts/Navbar";
import { SocialNetwork } from "../../components/SocialNetwork";

export function Clinic() {
  return (
    <>
      <header>
        <Navbar />
      </header>
      <main className="flex flex-col gap-8">
        <CoverClinic />
        <DataClinic />
        <ContactClinic />
        <InfoClinic />
        <ServiceClinic />
        <SocialNetwork />
      </main>
    </>
  );
}
