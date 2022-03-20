using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Type-Null Species to store common natural stats of all Type-Nulls
	#region Type-NullSpecies
	public class TypeNullSpecies : PokemonSpecies
	{
#nullable enable
		private static TypeNullSpecies? _instance = null;
#nullable restore
        public static TypeNullSpecies Instance => _instance ?? (_instance = new TypeNullSpecies());

		#region Type-NullSpecies Constructor
		public TypeNullSpecies() : base(
			772,
			"Type-Null",
			Normal.Instance,
			1.9,
			120.5,
			new PokemonStats(
				95, // HPs
				95, 95, // Attack & Defense
				95, 95, // Spacial Attack & Defense
				59 // Speed
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
				"Razor-Wind",
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Thunder-Wave",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Hail",
				"Facade",
				"Imprison",
				"Crush-Claw",
				"Metal-Sound",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Payback",
				"Heal-Block",
				"Punishment",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Double-Hit",
				"Flame-Charge",
				"Round",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}