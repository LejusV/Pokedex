using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Feebas Species to store common natural stats of all Feebass
	#region SpeciesFeebas
	public class SpeciesFeebas : PokemonSpecies
	{
#nullable enable
		private static SpeciesFeebas? _instance = null;
#nullable restore
        public static SpeciesFeebas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFeebas();
                }
                return _instance;
            }
        }

		#region SpeciesFeebas Constructor
		public SpeciesFeebas() : base(
			"Feebas",
			0.6,
			7.4,
			20, // HPs
			15, 20, // Attack & Defense
			10, 55, // Special Attack & Defense
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
				"Tackle",
				"Double-Edge",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Waterfall",
				"Swift",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Tickle",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Captivate",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Feebas PokemonInstance Class
	#region Feebas
	public class FeebasInstance : PokemonInstance
	{
		#region Feebas Constructors
		/// <summary>
		/// Feebas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FeebasInstance(string nickname, int level)
		: base(
				349,
				SpeciesFeebas.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Builder only waiting for a Level
		/// </summary>
		public FeebasInstance(int level)
		: base(
				349,
				SpeciesFeebas.Instance, // PokemonInstance Species
				"Feebas", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Feebas() : base(
			349,
			SpeciesFeebas.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}