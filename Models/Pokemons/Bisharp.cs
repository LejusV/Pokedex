using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bisharp Species to store common natural stats of all Bisharps
	#region SpeciesBisharp
	public class SpeciesBisharp : PokemonSpecies
	{
#nullable enable
		private static SpeciesBisharp? _instance = null;
#nullable restore
        public static SpeciesBisharp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBisharp();
                }
                return _instance;
            }
        }

		#region SpeciesBisharp Constructor
		public SpeciesBisharp() : base(
			625,
			"Bisharp",
			1.6,
			70.0,
			65, // HPs
			125, 100, // Attack & Defense
			60, 70, // Special Attack & Defense
			70		
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
				"Scratch",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Metal-Burst",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Retaliate",
				"Dual-Chop",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Bisharp PokemonInstance Class
	#region Bisharp
	public class BisharpInstance : PokemonInstance
	{
		#region Bisharp Constructors
		/// <summary>
		/// Bisharp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BisharpInstance(string nickname, int level)
		: base(
				SpeciesBisharp.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Builder only waiting for a Level
		/// </summary>
		public BisharpInstance(int level)
		: base(
				SpeciesBisharp.Instance, // PokemonInstance Species
				"Bisharp", level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BisharpInstance() : base(
			SpeciesBisharp.Instance, // PokemonInstance Species
			Dark.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}