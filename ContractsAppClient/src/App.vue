<template>
  <div class="container">
    <FormContract @contractInfo="updateContractInfo" />
    <InfoContract v-if="contractInfo" :contractInfo="contractInfo" />
  </div>
</template>

<script>
import FormContract from './components/FormContract.vue';
import InfoContract from './components/InfoContract.vue';

export default {
  data() {
    return {
      contractInfo: null,
    };
  },
  methods: {
    updateContractInfo(info) {
      this.contractInfo = info;
    },
  },
  components: {
    FormContract,
    InfoContract,
  },
};
</script>

<style>
  .container {
    padding: 1em;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
</style>
