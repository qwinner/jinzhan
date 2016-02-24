using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace JinZhan
{
    /// <summary>
    /// �������ק��
    /// </summary>
    public class Drag
    {
            private static bool isMouseDown = false;
            private static Point mouseOffset;
            private static Form _form;
            public Drag() { }

            /**/
            /// <summary>
            /// �ڴ�����������ק�¼�
            /// </summary>
            /// <param name="control">�ؼ�����</param>
            public static void bindControl(Control control)
            {
                //����ؼ�Ϊ�ա�
                if (control == null)
                {
                    return;
                }
                _form = control.FindForm();
                //��������϶������ƶ��¼�
                control.MouseMove += new MouseEventHandler(control_MouseMove);
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
            }
            /**/
            /// <summary>
            /// ��갴��֮ʱ�������������ڴ����λ��
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private static void control_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Control control = sender as Control;
                    int offsetX = -e.X;
                    int offsetY = -e.Y;
                    //�ж��Ǵ��廹�ǿؼ����Ӷ��Ľ��������ڴ����λ��
                    if (!(control is System.Windows.Forms.Form))
                    {
                        offsetX = offsetX - control.Left;
                        offsetY = offsetY - control.Top;
                    }
                    //�жϴ�����û�б��������Ӷ��Ľ��������ڴ����λ��
                    if (_form.FormBorderStyle != FormBorderStyle.None)
                    {
                        offsetX = offsetX - SystemInformation.FrameBorderSize.Width;
                        offsetY = offsetY - SystemInformation.FrameBorderSize.Height - SystemInformation.CaptionHeight;
                    }
                    mouseOffset = new Point(offsetX, offsetY);
                    isMouseDown = true;
                }
            }
            /**/
            /// <summary>
            /// �ƶ�����ʱ��ı䴰��λ��
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private static void control_MouseMove(object sender, MouseEventArgs e)
            {
                if (isMouseDown)
                {
                    Point mouse = Control.MousePosition;
                    mouse.Offset(mouseOffset.X, mouseOffset.Y);
                    _form.Location = mouse;
                }
            }
            /**/
            /// <summary>
            /// �ɿ�����ʱ�������¼�
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private static void control_MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
            }
        }
}
