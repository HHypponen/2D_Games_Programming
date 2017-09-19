using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class PlayerSpaceship : SpaceshipBase
    {
        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";
        public const string FireButtonName = "Fire1";

        private Vector3 GetInputVector()
        {
            //Vector3 movementVector = Vector3.zero;

            float horizontalInput = Input.GetAxis(HorizontalAxis);
            float verticalInput = Input.GetAxis(VerticalAxis);

            Vector3 movementVector = new Vector3(horizontalInput, verticalInput);

            return movementVector;
        }

        protected override void Update()
        {
            base.Update();

            if (Input.GetButton(FireButtonName))
            {
                Shoot();
            }
        }

        protected override void Move()
        {
            Vector3 inputVector = GetInputVector();
            Vector2 movementVector = inputVector * Speed;
            transform.Translate(movementVector * Time.deltaTime);
        }

      

        
    }
}