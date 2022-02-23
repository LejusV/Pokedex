using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Graveler Specie to store common natural stats of every {'abilities': ['rock-head', 'sturdy', 'sand-veil'], 'base_experience': 137, 'height': 10, 'id': 75, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'flamethrower', 'submission', 'counter', 'seismic-toss', 'strength', 'rock-throw', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'harden', 'defense-curl', 'bide', 'metronome', 'self-destruct', 'fire-blast', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'dynamic-punch', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'superpower', 'brick-break', 'secret-power', 'mud-sport', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'gyro-ball', 'natural-gift', 'fling', 'sucker-punch', 'rock-polish', 'earth-power', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'smack-down', 'round', 'incinerate', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'graveler', 'stats': {'hp': 55, 'attack': 95, 'defense': 115, 'special-attack': 45, 'special-defense': 45, 'speed': 35}, 'types': ['rock', 'ground'], 'weight': 1050, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ゴローン', 'roomaji': 'Golone', 'ko': '데구리', 'zh-Hant': '隆隆石', 'fr': 'Gravalanch', 'de': 'Georok', 'es': 'Graveler', 'it': 'Graveler', 'en': 'Graveler', 'ja': 'ゴローン', 'zh-Hans': '隆隆石'}, 'genera': {'ja-Hrkt': 'がんせきポケモン', 'ko': '암석포켓몬', 'zh-Hant': '岩石寶可夢', 'fr': 'Pokémon Roche', 'de': 'Gestein', 'es': 'Pokémon Roca', 'it': 'Pokémon Roccia', 'en': 'Rock Pokémon', 'ja': 'がんせきポケモン', 'zh-Hans': '岩石宝可梦'}}
	public class SpecieGraveler : PokemonSpecie
	{
#nullable enable
		private static SpecieGraveler? _instance = null;
#nullable restore
        public static SpecieGraveler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGraveler();
                }
                return _instance;
            }
        }

		public SpecieGraveler() : base(
			"Graveler",
			55, // HPs
			95, 115, // Attack & Defense
			45, 45, // Special Attack & Defense
			35			
		) {}
	}


	//Graveler Pokemon Class
	public class Graveler : Pokemon
	{

		public Graveler(string nickname, int level) : base(
			75,
			SpecieGraveler.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Ground.Instance			
		) {}

		public Graveler() : base(
			75,
			SpecieGraveler.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}