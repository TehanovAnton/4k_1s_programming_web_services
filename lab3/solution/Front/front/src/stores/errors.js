import { defineStore } from "pinia"
import { computed, ref, watch } from "vue";

export const useErrorsStore = defineStore('errors', () => {
  const error = ref({ ErrorCode: '', ErrorDescriptionUrl: '' })
  
  function setError(errorData) {
    error.value = errorData;
  }

  return { error, setError }
})