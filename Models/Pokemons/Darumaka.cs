using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Darumaka Specie to store common natural stats of every {'abilities': ['hustle', 'inner-focus'], 'base_experience': 63, 'height': 6, 'id': 554, 'moves': ['fire-punch', 'headbutt', 'tackle', 'take-down', 'thrash', 'roar', 'flamethrower', 'strength', 'solar-beam', 'dig', 'toxic', 'rage', 'double-team', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'flame-wheel', 'snore', 'protect', 'belly-drum', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'yawn', 'endeavor', 'snatch', 'secret-power', 'overheat', 'rock-tomb', 'extrasensory', 'hammer-arm', 'gyro-ball', 'u-turn', 'fling', 'flare-blitz', 'fire-fang', 'zen-headbutt', 'grass-knot', 'flame-charge', 'round', 'incinerate', 'work-up', 'confide', 'power-up-punch'], 'name': 'darumaka', 'stats': {'hp': 70, 'attack': 90, 'defense': 45, 'special-attack': 15, 'special-defense': 45, 'speed': 50}, 'types': ['fire'], 'weight': 375, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'red', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ダルマッカ', 'ko': '달막화', 'zh-Hant': '火紅不倒翁', 'fr': 'Darumarond', 'de': 'Flampion', 'es': 'Darumaka', 'it': 'Darumaka', 'en': 'Darumaka', 'ja': 'ダルマッカ', 'zh-Hans': '火红不倒翁'}, 'genera': {'ja-Hrkt': 'だるまポケモン', 'ko': '달마포켓몬', 'zh-Hant': '不倒翁寶可夢', 'fr': 'Pokémon Daruma', 'de': 'Lampion', 'es': 'Pokémon Daruma', 'it': 'Pokémon Daruma', 'en': 'Zen Charm Pokémon', 'ja': 'だるまポケモン', 'zh-Hans': '不倒翁宝可梦'}}
	public class SpecieDarumaka : PokemonSpecie
	{
#nullable enable
		private static SpecieDarumaka? _instance = null;
#nullable restore
        public static SpecieDarumaka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarumaka();
                }
                return _instance;
            }
        }

		public SpecieDarumaka() : base(
			"Darumaka",
			70, // HPs
			90, 45, // Attack & Defense
			15, 45, // Special Attack & Defense
			50			
		) {}
	}


	//Darumaka Pokemon Class
	public class Darumaka : Pokemon
	{

		public Darumaka(string nickname, int level) : base(
			554,
			SpecieDarumaka.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Darumaka() : base(
			554,
			SpecieDarumaka.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}