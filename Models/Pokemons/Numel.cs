using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Numel Species to store common natural stats of all Numels
	#region SpeciesNumel
	public class SpeciesNumel : PokemonSpecies
	{
#nullable enable
		private static SpeciesNumel? _instance = null;
#nullable restore
        public static SpeciesNumel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNumel();
                }
                return _instance;
            }
        }

		#region SpeciesNumel Constructor
		public SpeciesNumel() : base(
			322,
			"Numel",
			0.7,
			24.0,
			60, // HPs
			60, 40, // Attack & Defense
			65, 45, // Special Attack & Defense
			35		
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
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Ember",
				"Flamethrower",
				"Strength",
				"Growth",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Howl",
				"Natural-Gift",
				"Earth-Power",
				"Mud-Bomb",
				"Lava-Plume",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Heavy-Slam",
				"Flame-Charge",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Numel PokemonInstance Class
	#region Numel
	public class NumelInstance : PokemonInstance
	{
		#region Numel Constructors
		/// <summary>
		/// Numel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NumelInstance(string nickname, int level)
		: base(
				SpeciesNumel.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Builder only waiting for a Level
		/// </summary>
		public NumelInstance(int level)
		: base(
				SpeciesNumel.Instance, // PokemonInstance Species
				"Numel", level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NumelInstance() : base(
			SpeciesNumel.Instance, // PokemonInstance Species
			Fire.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}