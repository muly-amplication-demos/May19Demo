import * as React from "react";
import { Edit, SimpleForm, EditProps, TextInput } from "react-admin";

export const MulyEdit = (props: EditProps): React.ReactElement => {
  return (
    <Edit {...props}>
      <SimpleForm>
        <TextInput label="fld1" source="fld1" />
      </SimpleForm>
    </Edit>
  );
};
