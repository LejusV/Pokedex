using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Celebi Species to store common natural stats of all Celebis
	#region SpeciesCelebi
	public class SpeciesCelebi : PokemonSpecies
	{
#nullable enable
		private static SpeciesCelebi? _instance = null;
#nullable restore
        public static SpeciesCelebi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCelebi();
                }
                return _instance;
            }
        }

		#region SpeciesCelebi Constructor
		public SpeciesCelebi() : base(
			"Celebi",
			0.6,
			5.0,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Hyper-Beam",
				"Leech-Seed",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Detect",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Heal-Block",
				"Last-Resort",
				"Worry-Seed",
				"Sucker-Punch",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Leaf-Storm",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Celebi PokemonInstance Class
	#region Celebi
	public class CelebiInstance : PokemonInstance
	{
		#region Celebi Constructors
		/// <summary>
		/// Celebi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CelebiInstance(string nickname, int level)
		: base(
				251,
				SpeciesCelebi.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Builder only waiting for a Level
		/// </summary>
		public CelebiInstance(int level)
		: base(
				251,
				SpeciesCelebi.Instance, // PokemonInstance Species
				"Celebi", level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Celebi Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Celebi() : base(
			251,
			SpeciesCelebi.Instance, // PokemonInstance Species
			Psychic.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}