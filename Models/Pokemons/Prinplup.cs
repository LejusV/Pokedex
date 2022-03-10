using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Prinplup Species to store common natural stats of all Prinplups
	#region SpeciesPrinplup
	public class SpeciesPrinplup : PokemonSpecies
	{
#nullable enable
		private static SpeciesPrinplup? _instance = null;
#nullable restore
        public static SpeciesPrinplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPrinplup();
                }
                return _instance;
            }
        }

		#region SpeciesPrinplup Constructor
		public SpeciesPrinplup() : base(
			"Prinplup",
			0.8,
			23.0,
			64, // HPs
			66, 68, // Attack & Defense
			81, 76, // Special Attack & Defense
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
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Drill-Peck",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Prinplup PokemonInstance Class
	#region Prinplup
	public class PrinplupInstance : PokemonInstance
	{
		#region Prinplup Constructors
		/// <summary>
		/// Prinplup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PrinplupInstance(string nickname, int level)
		: base(
				394,
				SpeciesPrinplup.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Builder only waiting for a Level
		/// </summary>
		public PrinplupInstance(int level)
		: base(
				394,
				SpeciesPrinplup.Instance, // PokemonInstance Species
				"Prinplup", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Prinplup Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Prinplup() : base(
			394,
			SpeciesPrinplup.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}