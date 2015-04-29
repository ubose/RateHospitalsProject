function hideIcon(self) {
    self.style.background = '#f1f1f1';
    self.style.padding = '5px 9px 0px 10px';
}

function restoreIcon(self) {
    self.style.background = '#f1f1f1 url(\'/Images/search24x24.png\') no-repeat 8px 10px';
    self.style.padding = '5px 9px 0px 50px';
}

function clearFeedbackForm(self) {
    var feedbackForm = document.getElementById('user-feedback-form');
    feedbackForm.clear();    
}