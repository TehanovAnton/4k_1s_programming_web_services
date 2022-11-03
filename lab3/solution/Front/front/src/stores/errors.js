import { defineStore } from "pinia"
import { computed, ref, watch } from "vue";

export const useErrorsStore = defineStore('errors', () => {
  const error = ref({ code: '', errorDescriptionUrl: '' })  

  return { error }
})