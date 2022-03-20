using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yungoos Species to store common natural stats of all Yungooss
	#region YungoosSpecies
	public class YungoosSpecies : PokemonSpecies
	{
#nullable enable
		private static YungoosSpecies? _instance = null;
#nullable restore
        public static YungoosSpecies Instance => _instance ?? (_instance = new YungoosSpecies());

		#region YungoosSpecies Constructor
		public YungoosSpecies() : base(
			734,
			"Yungoos",
			Normal.Instance,
			0.4,
			6.0,
			new PokemonStats(
				48, // HPs
				70, 30, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				45 // Speed
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
				"Tackle",
				"Take-Down",
				"Thrash",
				"Leer",
				"Bite",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Revenge",
				"Yawn",
				"Odor-Sleuth",
				"Rock-Tomb",
				"U-Turn",
				"Payback",
				"Last-Resort",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}