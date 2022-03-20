using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Venonat Species to store common natural stats of all Venonats
	#region VenonatSpecies
	public class VenonatSpecies : PokemonSpecies
	{
#nullable enable
		private static VenonatSpecies? _instance = null;
#nullable restore
        public static VenonatSpecies Instance => _instance ?? (_instance = new VenonatSpecies());

		#region VenonatSpecies Constructor
		public VenonatSpecies() : base(
			48,
			"Venonat",
			Bug.Instance, Poison.Instance,
			1.0,
			30.0,
			new PokemonStats(
				60, // HPs
				55, 50, // Attack & Defense
				40, 55, // Spacial Attack & Defense
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Disable",
				"Psybeam",
				"Mega-Drain",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"String-Shot",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Leech-Life",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Foresight",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Sweet-Scent",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Skill-Swap",
				"Secret-Power",
				"Poison-Fang",
				"Signal-Beam",
				"Natural-Gift",
				"Toxic-Spikes",
				"Zen-Headbutt",
				"Captivate",
				"Bug-Bite",
				"Venoshock",
				"Rage-Powder",
				"Round",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}