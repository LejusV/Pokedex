using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Seadra Species to store common natural stats of all Seadras
	#region SpeciesSeadra
	public class SpeciesSeadra : PokemonSpecies
	{
#nullable enable
		private static SpeciesSeadra? _instance = null;
#nullable restore
        public static SpeciesSeadra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSeadra();
                }
                return _instance;
            }
        }

		#region SpeciesSeadra Constructor
		public SpeciesSeadra() : base(
			"Seadra",
			1.2,
			25.0,
			55, // HPs
			65, 95, // Attack & Defense
			95, 45, // Special Attack & Defense
			85		
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
				"Headbutt",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Dragon-Dance",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Dragon-Pulse",
				"Giga-Impact",
				"Flash-Cannon",
				"Captivate",
				"Round",
				"Scald",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Seadra PokemonInstance Class
	#region Seadra
	public class SeadraInstance : PokemonInstance
	{
		#region Seadra Constructors
		/// <summary>
		/// Seadra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SeadraInstance(string nickname, int level)
		: base(
				117,
				SpeciesSeadra.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Builder only waiting for a Level
		/// </summary>
		public SeadraInstance(int level)
		: base(
				117,
				SpeciesSeadra.Instance, // PokemonInstance Species
				"Seadra", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Seadra() : base(
			117,
			SpeciesSeadra.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}