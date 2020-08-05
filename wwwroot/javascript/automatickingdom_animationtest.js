Blockly.Blocks['automatickingdom_animationtest'] = {
    init: function () {
        this.appendDummyInput()
            .appendField(new Blockly.FieldLabelSerializable("Execute Animation"), "ExecuteAnimation")
            .appendField(new Blockly.FieldDropdown([["TPose", "TPose"], ["Walking", "Walking"], ["Running", "Running"], ["Attack", "Attack"], ["Idle", "Idle"]]), "AnimationSelection");
        this.setPreviousStatement(true, null);
        this.setNextStatement(true, null);
        this.setColour(230);
        this.setTooltip("Choose Animation");
        this.setHelpUrl("");
    }
};