using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aromatisse Species to store common natural stats of all Aromatisses
	#region SpeciesAromatisse
	public class SpeciesAromatisse : PokemonSpecies
	{
#nullable enable
		private static SpeciesAromatisse? _instance = null;
#nullable restore
        public static SpeciesAromatisse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAromatisse();
                }
                return _instance;
            }
        }

		#region SpeciesAromatisse Constructor
		public SpeciesAromatisse() : base(
			"Aromatisse",
			0.8,
			15.5,
			101, // HPs
			72, 72, // Attack & Defense
			99, 89, // Special Attack & Defense
			29		
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
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Aromatherapy",
				"Odor-Sleuth",
				"Covet",
				"Calm-Mind",
				"Gyro-Ball",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Trick-Room",
				"Charge-Beam",
				"Psyshock",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Aromatisse PokemonInstance Class
	#region Aromatisse
	public class AromatisseInstance : PokemonInstance
	{
		#region Aromatisse Constructors
		/// <summary>
		/// Aromatisse Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AromatisseInstance(string nickname, int level)
		: base(
				683,
				SpeciesAromatisse.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Builder only waiting for a Level
		/// </summary>
		public AromatisseInstance(int level)
		: base(
				683,
				SpeciesAromatisse.Instance, // PokemonInstance Species
				"Aromatisse", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Aromatisse() : base(
			683,
			SpeciesAromatisse.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}