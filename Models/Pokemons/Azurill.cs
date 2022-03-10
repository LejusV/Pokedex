using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Azurill Species to store common natural stats of all Azurills
	#region SpeciesAzurill
	public class SpeciesAzurill : PokemonSpecies
	{
#nullable enable
		private static SpeciesAzurill? _instance = null;
#nullable restore
        public static SpeciesAzurill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAzurill();
                }
                return _instance;
            }
        }

		#region SpeciesAzurill Constructor
		public SpeciesAzurill() : base(
			"Azurill",
			0.2,
			2.0,
			50, // HPs
			20, 40, // Attack & Defense
			20, 40, // Special Attack & Defense
			20		
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
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Sing",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Waterfall",
				"Swift",
				"Bubble",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Camouflage",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Muddy-Water",
				"Bounce",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Copycat",
				"Captivate",
				"Soak",
				"Round",
				"Scald",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Azurill PokemonInstance Class
	#region Azurill
	public class AzurillInstance : PokemonInstance
	{
		#region Azurill Constructors
		/// <summary>
		/// Azurill Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AzurillInstance(string nickname, int level)
		: base(
				298,
				SpeciesAzurill.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Builder only waiting for a Level
		/// </summary>
		public AzurillInstance(int level)
		: base(
				298,
				SpeciesAzurill.Instance, // PokemonInstance Species
				"Azurill", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Azurill Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Azurill() : base(
			298,
			SpeciesAzurill.Instance, // PokemonInstance Species
			Normal.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}