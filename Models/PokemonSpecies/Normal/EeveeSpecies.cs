using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Eevee Species to store common natural stats of all Eevees
	#region EeveeSpecies
	public class EeveeSpecies : PokemonSpecies
	{
#nullable enable
		private static EeveeSpecies? _instance = null;
#nullable restore
        public static EeveeSpecies Instance => _instance ?? (_instance = new EeveeSpecies());

		#region EeveeSpecies Constructor
		public EeveeSpecies() : base(
			133,
			"Eevee",
			Normal.Instance,
			0.3,
			6.5,
			new PokemonStats(
				55, // HPs
				55, 50, // Attack & Defense
				45, 65, // Spacial Attack & Defense
				55 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Wish",
				"Yawn",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Trump-Card",
				"Last-Resort",
				"Captivate",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}