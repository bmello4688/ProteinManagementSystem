$('#myModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var proteinName = button.data('name') // Extract protein name
    var proteinSequence = button.data('sequence') // Extract protein's amino acid sequence
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    modal.find('.modal-title').text('Protein ' + proteinName + ' Amino Acid Sequence')
    modal.find('.modal-body div p').text(proteinSequence)
})