using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Hippopotas Species to store common natural stats of all Hippopotass
	#region SpeciesHippopotas
	public class SpeciesHippopotas : PokemonSpecies
	{
#nullable enable
		private static SpeciesHippopotas? _instance = null;
#nullable restore
        public static SpeciesHippopotas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHippopotas();
                }
                return _instance;
            }
        }

		#region SpeciesHippopotas Constructor
		public SpeciesHippopotas() : base(
			449,
			"Hippopotas",
			0.8,
			49.5,
			68, // HPs
			72, 78, // Attack & Defense
			38, 42, // Special Attack & Defense
			32		
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
				"Whirlwind",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Superpower",
				"Revenge",
				"Yawn",
				"Secret-Power",
				"Slack-Off",
				"Rock-Tomb",
				"Sand-Tomb",
				"Water-Pulse",
				"Natural-Gift",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Hippopotas PokemonInstance Class
	#region Hippopotas
	public class HippopotasInstance : PokemonInstance
	{
		#region Hippopotas Constructors
		/// <summary>
		/// Hippopotas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HippopotasInstance(string nickname, int level)
		: base(
				SpeciesHippopotas.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Builder only waiting for a Level
		/// </summary>
		public HippopotasInstance(int level)
		: base(
				SpeciesHippopotas.Instance, // PokemonInstance Species
				"Hippopotas", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public HippopotasInstance() : base(
			SpeciesHippopotas.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}