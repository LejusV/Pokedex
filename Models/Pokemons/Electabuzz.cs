using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Electabuzz Species to store common natural stats of all Electabuzzs
	#region SpeciesElectabuzz
	public class SpeciesElectabuzz : PokemonSpecies
	{
#nullable enable
		private static SpeciesElectabuzz? _instance = null;
#nullable restore
        public static SpeciesElectabuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesElectabuzz();
                }
                return _instance;
            }
        }

		#region SpeciesElectabuzz Constructor
		public SpeciesElectabuzz() : base(
			125,
			"Electabuzz",
			1.1,
			30.0,
			65, // HPs
			83, 57, // Attack & Defense
			95, 85, // Special Attack & Defense
			105		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Low-Sweep",
				"Round",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Electabuzz PokemonInstance Class
	#region Electabuzz
	public class ElectabuzzInstance : PokemonInstance
	{
		#region Electabuzz Constructors
		/// <summary>
		/// Electabuzz Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ElectabuzzInstance(string nickname, int level)
		: base(
				SpeciesElectabuzz.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Builder only waiting for a Level
		/// </summary>
		public ElectabuzzInstance(int level)
		: base(
				SpeciesElectabuzz.Instance, // PokemonInstance Species
				"Electabuzz", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ElectabuzzInstance() : base(
			SpeciesElectabuzz.Instance, // PokemonInstance Species
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}