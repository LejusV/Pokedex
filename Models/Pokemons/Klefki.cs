using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Klefki Species to store common natural stats of all Klefkis
	#region SpeciesKlefki
	public class SpeciesKlefki : PokemonSpecies
	{
#nullable enable
		private static SpeciesKlefki? _instance = null;
#nullable restore
        public static SpeciesKlefki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKlefki();
                }
                return _instance;
            }
        }

		#region SpeciesKlefki Constructor
		public SpeciesKlefki() : base(
			"Klefki",
			0.2,
			3.0,
			57, // HPs
			80, 91, // Attack & Defense
			80, 87, // Special Attack & Defense
			75		
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
				"Tackle",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Spikes",
				"Lock-On",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Metal-Sound",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Heal-Block",
				"Last-Resort",
				"Magnet-Rise",
				"Switcheroo",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Psyshock",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Draining-Kiss",
				"Crafty-Shield",
				"Play-Rough",
				"Fairy-Wind",
				"Fairy-Lock",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Klefki PokemonInstance Class
	#region Klefki
	public class KlefkiInstance : PokemonInstance
	{
		#region Klefki Constructors
		/// <summary>
		/// Klefki Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KlefkiInstance(string nickname, int level)
		: base(
				707,
				SpeciesKlefki.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Builder only waiting for a Level
		/// </summary>
		public KlefkiInstance(int level)
		: base(
				707,
				SpeciesKlefki.Instance, // PokemonInstance Species
				"Klefki", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klefki Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Klefki() : base(
			707,
			SpeciesKlefki.Instance, // PokemonInstance Species
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}