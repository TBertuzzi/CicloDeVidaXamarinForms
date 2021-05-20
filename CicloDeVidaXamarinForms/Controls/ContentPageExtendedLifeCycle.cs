using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CicloDeVidaXamarinForms.Controls
{
    public abstract class ContentPageExtendedLifeCycle : ContentPage
    {
        private int modalStackPushedCount;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Application.Current.ModalPushing -= Current_ModalPushing;
            Application.Current.ModalPushing += Current_ModalPushing;
            Application.Current.ModalPopped -= Current_ModalPopped;
            Application.Current.ModalPopped += Current_ModalPopped;

            this.OnAppearing(this.modalStackPushedCount > 0);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Application.Current.ModalPushing -= Current_ModalPushing;
            Application.Current.ModalPopped -= Current_ModalPopped;

            this.OnDisappearing(this.modalStackPushedCount > 0);
        }

        private void Current_ModalPushing(object sender, ModalPushingEventArgs e)
        {
            this.modalStackPushedCount++;
        }
        private void Current_ModalPopped(object sender, ModalPoppedEventArgs e)
        {
            System.Diagnostics.Debug.Assert(this.modalStackPushedCount > 0);
            this.modalStackPushedCount--;
        }

        protected virtual void OnAppearing(bool causedByModalPop) { }
        protected virtual void OnDisappearing(bool causedByModalPush) { }
    }
}