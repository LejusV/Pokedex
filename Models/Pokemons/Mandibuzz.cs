using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mandibuzz Species to store common natural stats of all Mandibuzzs
	#region SpeciesMandibuzz
	public class SpeciesMandibuzz : PokemonSpecies
	{
#nullable enable
		private static SpeciesMandibuzz? _instance = null;
#nullable restore
        public static SpeciesMandibuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMandibuzz();
                }
                return _instance;
            }
        }

		#region SpeciesMandibuzz Constructor
		public SpeciesMandibuzz() : base(
			"Mandibuzz",
			1.2,
			39.5,
			110, // HPs
			65, 105, // Attack & Defense
			55, 95, // Special Attack & Defense
			80		
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Leer",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Bone-Rush",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Punishment",
				"Dark-Pulse",
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Nasty-Plot",
				"Defog",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Mandibuzz PokemonInstance Class
	#region Mandibuzz
	public class MandibuzzInstance : PokemonInstance
	{
		#region Mandibuzz Constructors
		/// <summary>
		/// Mandibuzz Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MandibuzzInstance(string nickname, int level)
		: base(
				630,
				SpeciesMandibuzz.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Builder only waiting for a Level
		/// </summary>
		public MandibuzzInstance(int level)
		: base(
				630,
				SpeciesMandibuzz.Instance, // PokemonInstance Species
				"Mandibuzz", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mandibuzz Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mandibuzz() : base(
			630,
			SpeciesMandibuzz.Instance, // PokemonInstance Species
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}