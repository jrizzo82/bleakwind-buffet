using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashCounter.xaml
    /// </summary>
    public partial class CashCounter : UserControl
    {
        /// <summary>
        /// Identifies the CashCounter.Step XAML attached property
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CashCounter), new PropertyMetadata(1));

        /// <summary>
        /// Identifies the CashCounter.Value XAML attached property
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(CashCounter),
                                                            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender |
                                                                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));

        /// <summary>
        /// Identifies the NumberBox.ValueClamped event
        /// </summary>
        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CashCounter));

        public static readonly RoutedEvent ValueChangedEvent = EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CashCounter));


        /// <summary>
        /// The amount each increment or decrement operation should change the value by
        /// </summary>
        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        /// <summary>
        /// The CashCounter's displayed value
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set 
            {
                SetValue(ValueProperty, value);
                this.RaiseEvent(new RoutedEventArgs(ValueChangedEvent));
            }
        }

        /// <summary>
        /// Event that is triggered when the value of this NumberBox changes
        /// </summary>
        public event RoutedEventHandler ValueClamped
        {
            add { AddHandler(ValueClampedEvent, value); }
            remove { RemoveHandler(ValueClampedEvent, value); }
        }

        /// <summary>
        /// Event that is triggered when the value of this NumberBox changes
        /// </summary>
        public event RoutedEventHandler ValueChanged
        {
            add { AddHandler(ValueChangedEvent, value); }
            remove { RemoveHandler(ValueChangedEvent, value); }
        }

        public CashCounter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click of the increment or decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        Value += Step;
                        break;
                    case "Decrement":
                        Value -= Step;
                        break;
                }
            }
            e.Handled = true;
        }

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {            
            if (e.Property.Name == "Value" && sender is CashCounter cc)
            {
                if (cc.Value < 0)
                {
                    cc.Value = 0;
                    cc.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
                else if (cc.Value > 100)
                {
                    cc.Value = 100;
                    cc.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
                cc.RaiseEvent(new RoutedEventArgs(ValueChangedEvent));
            }
        }
    }
}
