using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Igglybuff Species to store common natural stats of all Igglybuffs
	#region SpeciesIgglybuff
	public class SpeciesIgglybuff : PokemonSpecies
	{
#nullable enable
		private static SpeciesIgglybuff? _instance = null;
#nullable restore
        public static SpeciesIgglybuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesIgglybuff();
                }
                return _instance;
            }
        }

		#region SpeciesIgglybuff Constructor
		public SpeciesIgglybuff() : base(
			"Igglybuff",
			0.3,
			1.0,
			90, // HPs
			30, 15, // Attack & Defense
			40, 20, // Special Attack & Defense
			15		
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
				"Pound",
				"Mega-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Punishment",
				"Last-Resort",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Work-Up",
				"Wild-Charge",
				"Misty-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Igglybuff PokemonInstance Class
	#region Igglybuff
	public class IgglybuffInstance : PokemonInstance
	{
		#region Igglybuff Constructors
		/// <summary>
		/// Igglybuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public IgglybuffInstance(string nickname, int level)
		: base(
				174,
				SpeciesIgglybuff.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Builder only waiting for a Level
		/// </summary>
		public IgglybuffInstance(int level)
		: base(
				174,
				SpeciesIgglybuff.Instance, // PokemonInstance Species
				"Igglybuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Igglybuff() : base(
			174,
			SpeciesIgglybuff.Instance, // PokemonInstance Species
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}