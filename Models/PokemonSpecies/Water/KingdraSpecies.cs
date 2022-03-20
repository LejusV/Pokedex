using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kingdra Species to store common natural stats of all Kingdras
	#region KingdraSpecies
	public class KingdraSpecies : PokemonSpecies
	{
#nullable enable
		private static KingdraSpecies? _instance = null;
#nullable restore
        public static KingdraSpecies Instance => _instance ?? (_instance = new KingdraSpecies());

		#region KingdraSpecies Constructor
		public KingdraSpecies() : base(
			230,
			"Kingdra",
			Water.Instance, Dragon.Instance,
			1.8,
			152.0,
			new PokemonStats(
				75, // HPs
				95, 95, // Attack & Defense
				95, 95, // Spacial Attack & Defense
				85 // Speed
			)			
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
				"Body-Slam",
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
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Focus-Energy",
				"Waterfall",
				"Swift",
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
				"Yawn",
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
				"Draco-Meteor",
				"Iron-Head",
				"Captivate",
				"Round",
				"Scald",
				"Quash",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}