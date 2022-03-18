using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Togetic Species to store common natural stats of all Togetics
	#region SpeciesTogetic
	public class SpeciesTogetic : PokemonSpecies
	{
#nullable enable
		private static SpeciesTogetic? _instance = null;
#nullable restore
        public static SpeciesTogetic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTogetic();
                }
                return _instance;
            }
        }

		#region SpeciesTogetic Constructor
		public SpeciesTogetic() : base(
			176,
			"Togetic",
			0.6,
			3.2,
			55, // HPs
			40, 85, // Attack & Defense
			80, 105, // Special Attack & Defense
			40		
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
				"Mega-Punch",
				"Fly",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Fire-Blast",
				"Swift",
				"Soft-Boiled",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Brick-Break",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Magical-Leaf",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Togetic PokemonInstance Class
	#region Togetic
	public class TogeticInstance : PokemonInstance
	{
		#region Togetic Constructors
		/// <summary>
		/// Togetic Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TogeticInstance(string nickname, int level)
		: base(
				SpeciesTogetic.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Builder only waiting for a Level
		/// </summary>
		public TogeticInstance(int level)
		: base(
				SpeciesTogetic.Instance, // PokemonInstance Species
				"Togetic", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togetic Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TogeticInstance() : base(
			SpeciesTogetic.Instance, // PokemonInstance Species
			Fairy.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}