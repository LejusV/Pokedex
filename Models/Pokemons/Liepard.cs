using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Liepard Species to store common natural stats of all Liepards
	#region SpeciesLiepard
	public class SpeciesLiepard : PokemonSpecies
	{
#nullable enable
		private static SpeciesLiepard? _instance = null;
#nullable restore
        public static SpeciesLiepard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLiepard();
                }
                return _instance;
            }
        }

		#region SpeciesLiepard Constructor
		public SpeciesLiepard() : base(
			510,
			"Liepard",
			1.1,
			37.5,
			64, // HPs
			88, 50, // Attack & Defense
			88, 50, // Special Attack & Defense
			106		
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
				"Cut",
				"Sand-Attack",
				"Growl",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Liepard PokemonInstance Class
	#region Liepard
	public class LiepardInstance : PokemonInstance
	{
		#region Liepard Constructors
		/// <summary>
		/// Liepard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LiepardInstance(string nickname, int level)
		: base(
				SpeciesLiepard.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Builder only waiting for a Level
		/// </summary>
		public LiepardInstance(int level)
		: base(
				SpeciesLiepard.Instance, // PokemonInstance Species
				"Liepard", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LiepardInstance() : base(
			SpeciesLiepard.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}