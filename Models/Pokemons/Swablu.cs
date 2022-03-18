using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swablu Species to store common natural stats of all Swablus
	#region SpeciesSwablu
	public class SpeciesSwablu : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwablu? _instance = null;
#nullable restore
        public static SpeciesSwablu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwablu();
                }
                return _instance;
            }
        }

		#region SpeciesSwablu Constructor
		public SpeciesSwablu() : base(
			333,
			"Swablu",
			0.4,
			1.2,
			45, // HPs
			40, 60, // Attack & Defense
			40, 75, // Special Attack & Defense
			50		
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
				"Fly",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Sing",
				"Mist",
				"Ice-Beam",
				"Peck",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Mirror-Move",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Outrage",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Feather-Dance",
				"Hyper-Voice",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Power-Swap",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Cotton-Guard",
				"Disarming-Voice",
				"Play-Rough",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Swablu PokemonInstance Class
	#region Swablu
	public class SwabluInstance : PokemonInstance
	{
		#region Swablu Constructors
		/// <summary>
		/// Swablu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwabluInstance(string nickname, int level)
		: base(
				SpeciesSwablu.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Builder only waiting for a Level
		/// </summary>
		public SwabluInstance(int level)
		: base(
				SpeciesSwablu.Instance, // PokemonInstance Species
				"Swablu", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SwabluInstance() : base(
			SpeciesSwablu.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}