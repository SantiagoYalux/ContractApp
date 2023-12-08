<template>
<form @submit.prevent="getContractInfo" class="form">
  <div class="mb-3 d-flex align-items-end">
    <div class="flex-grow-1 me-2">
      <label for="contractId" class="form-label">Ingrese el ID del contrato:</label>
      <input v-model="contractId" type="number" class="form-control" id="contractId" required />
    </div>
    <button type="submit" class="btn btn-outline-primary btnGetInfo align-self-end">Obtener</button>
  </div>
</form>
</template>
  
<script>
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.css'; // Importar el archivo de estilo de Bootstrap

export default {
  data() {
    return {
      contractId: "",
    };
  },
  methods: {
    async getContractInfo() {
      if(this.contractId <= 0){
       alert("Debes ingresar un numero mayor a 0");
       return; 
      }
        try {
        const response = await axios.get(`https:/localhost:7048/api/Contract/Get?ID=${this.contractId}`);
        this.$emit('contractInfo', response.data);
      } catch (error) {

        if (error.response) 
        {
          const responseData = error.response.data;
          const apiErrorMessage = responseData.message;
          this.$emit('contractInfo', null);
          alert(apiErrorMessage);
        } 
        else {
          console.error("Error");
        }

      }
    },
  },
};
</script>

