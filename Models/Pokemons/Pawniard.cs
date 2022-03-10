using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pawniard Species to store common natural stats of all Pawniards
	#region SpeciesPawniard
	public class SpeciesPawniard : PokemonSpecies
	{
#nullable enable
		private static SpeciesPawniard? _instance = null;
#nullable restore
        public static SpeciesPawniard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPawniard();
                }
                return _instance;
            }
        }

		#region SpeciesPawniard Constructor
		public SpeciesPawniard() : base(
			"Pawniard",
			0.5,
			10.2,
			45, // HPs
			85, 70, // Attack & Defense
			40, 40, // Special Attack & Defense
			60		
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
				"Headbutt",
				"Leer",
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
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Magnet-Rise",
				"Rock-Polish",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Claw",
				"Psycho-Cut",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Quick-Guard",
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

	//Pawniard PokemonInstance Class
	#region Pawniard
	public class PawniardInstance : PokemonInstance
	{
		#region Pawniard Constructors
		/// <summary>
		/// Pawniard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PawniardInstance(string nickname, int level)
		: base(
				624,
				SpeciesPawniard.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Builder only waiting for a Level
		/// </summary>
		public PawniardInstance(int level)
		: base(
				624,
				SpeciesPawniard.Instance, // PokemonInstance Species
				"Pawniard", level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pawniard Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pawniard() : base(
			624,
			SpeciesPawniard.Instance, // PokemonInstance Species
			Dark.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}