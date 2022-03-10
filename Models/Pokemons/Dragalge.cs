using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dragalge Species to store common natural stats of all Dragalges
	#region SpeciesDragalge
	public class SpeciesDragalge : PokemonSpecies
	{
#nullable enable
		private static SpeciesDragalge? _instance = null;
#nullable restore
        public static SpeciesDragalge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDragalge();
                }
                return _instance;
            }
        }

		#region SpeciesDragalge Constructor
		public SpeciesDragalge() : base(
			"Dragalge",
			1.8,
			81.5,
			65, // HPs
			75, 90, // Attack & Defense
			97, 123, // Special Attack & Defense
			44		
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
				"Tail-Whip",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Smokescreen",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Icy-Wind",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Bounce",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Draco-Meteor",
				"Gunk-Shot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dragalge PokemonInstance Class
	#region Dragalge
	public class DragalgeInstance : PokemonInstance
	{
		#region Dragalge Constructors
		/// <summary>
		/// Dragalge Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DragalgeInstance(string nickname, int level)
		: base(
				691,
				SpeciesDragalge.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Builder only waiting for a Level
		/// </summary>
		public DragalgeInstance(int level)
		: base(
				691,
				SpeciesDragalge.Instance, // PokemonInstance Species
				"Dragalge", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Dragalge() : base(
			691,
			SpeciesDragalge.Instance, // PokemonInstance Species
			Poison.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}