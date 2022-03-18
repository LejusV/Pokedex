using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Croagunk Species to store common natural stats of all Croagunks
	#region SpeciesCroagunk
	public class SpeciesCroagunk : PokemonSpecies
	{
#nullable enable
		private static SpeciesCroagunk? _instance = null;
#nullable restore
        public static SpeciesCroagunk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCroagunk();
                }
                return _instance;
            }
        }

		#region SpeciesCroagunk Constructor
		public SpeciesCroagunk() : base(
			453,
			"Croagunk",
			0.7,
			23.0,
			48, // HPs
			61, 40, // Attack & Defense
			61, 40, // Special Attack & Defense
			50		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Poison-Sting",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Meditate",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Feint",
				"Acupressure",
				"Payback",
				"Embargo",
				"Fling",
				"Me-First",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Nasty-Plot",
				"Bullet-Punch",
				"Mud-Bomb",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Croagunk PokemonInstance Class
	#region Croagunk
	public class CroagunkInstance : PokemonInstance
	{
		#region Croagunk Constructors
		/// <summary>
		/// Croagunk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CroagunkInstance(string nickname, int level)
		: base(
				SpeciesCroagunk.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Builder only waiting for a Level
		/// </summary>
		public CroagunkInstance(int level)
		: base(
				SpeciesCroagunk.Instance, // PokemonInstance Species
				"Croagunk", level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CroagunkInstance() : base(
			SpeciesCroagunk.Instance, // PokemonInstance Species
			Poison.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}