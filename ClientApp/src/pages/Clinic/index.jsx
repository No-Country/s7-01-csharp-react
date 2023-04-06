import { CoverClinic } from "../../components/CoverClinic";
import { DataClinic } from "../../components/DataClinic";
import { ContactClinic } from "../../components/ContactClinic";
import { InfoClinic } from "../../components/InfoClinic";
import { ServiceClinic } from "../../components/ServiceClinic";
import Navbar from "../../components/Layouts/Navbar";
import { SocialNetwork } from "../../components/SocialNetwork";
import { OtherClinic } from "../../components/OtherClinic";

export function Clinic() {
  return (
    <>
      <header>
        <Navbar />
      </header>
      <main className="flex flex-col gap-8">
        <section className="container relative mx-auto">
          <CoverClinic />
        </section>

        <section className="mt-10 mx-4">
          <DataClinic />
        </section>
        <section className="mx-4">
          <ContactClinic />
        </section>
        <section className="mx-4">
          <InfoClinic />
        </section>
        <section className="mx-4">
          <ServiceClinic />
        </section>

        <SocialNetwork />
        <section className="mx-4">
          <OtherClinic />
        </section>
      </main>
    </>
  );
}
